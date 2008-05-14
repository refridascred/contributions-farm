-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (ratio, rank, token, level) VALUES (60.73, 99, 'strict', 97);
INSERT INTO layout_items (ratio, rank, token, level) VALUES (62.45, 20, 'green', 43);
INSERT INTO layout_items (ratio, rank, token, level) VALUES (46.69, 77, 'standard', 60);
