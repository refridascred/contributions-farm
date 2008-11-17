-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (level, token, rank, ratio) VALUES (6, 'cached', 34, 11.2);
INSERT INTO layout_items (level, token, rank, ratio) VALUES (87, 'edge', 69, 7.14);
INSERT INTO layout_items (level, token, rank, ratio) VALUES (26, 'green', 74, 33.12);
