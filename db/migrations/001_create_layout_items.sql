-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (ratio, active, rank, weight, state) VALUES (58.97, 91, 11, 1.41, 'open');
INSERT INTO layout_items (ratio, active, rank, weight, state) VALUES (54.52, 25, 72, 39.19, 'local');
INSERT INTO layout_items (ratio, active, rank, weight, state) VALUES (12.41, 22, 24, 80.19, 'fallback');
