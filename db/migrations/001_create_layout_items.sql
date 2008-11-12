-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (ratio, weight, state, active) VALUES (41.11, 65.27, 'staging', 2);
INSERT INTO layout_items (ratio, weight, state, active) VALUES (27.71, 30.49, 'green', 71);
INSERT INTO layout_items (ratio, weight, state, active) VALUES (65.75, 3.3, 'fallback', 48);
