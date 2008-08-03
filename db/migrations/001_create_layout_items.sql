-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, token, ratio, weight, rank) VALUES (9, 'edge', 53.2, 20.12, 3);
INSERT INTO layout_items (level, token, ratio, weight, rank) VALUES (23, 'fallback', 58.73, 75.59, 15);
INSERT INTO layout_items (level, token, ratio, weight, rank) VALUES (60, 'primary', 53.41, 49.1, 95);
