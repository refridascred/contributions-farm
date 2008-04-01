-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, state, active, weight) VALUES (72.22, 'eu-west', 83, 24.58);
INSERT INTO layout_items (ratio, state, active, weight) VALUES (36.91, 'stable', 15, 43.18);
INSERT INTO layout_items (ratio, state, active, weight) VALUES (46.49, 'stable', 83, 94.88);
