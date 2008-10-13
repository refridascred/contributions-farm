-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (level, ratio, active, state, weight) VALUES (29, 38.51, 70, 'fallback', 53.91);
INSERT INTO layout_items (level, ratio, active, state, weight) VALUES (88, 16.79, 27, 'green', 87.12);
