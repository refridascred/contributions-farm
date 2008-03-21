-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (active, state, rank, weight, level) VALUES (55, 'fallback', 69, 12.52, 49);
INSERT INTO layout_items (active, state, rank, weight, level) VALUES (91, 'fallback', 20, 67.54, 37);
