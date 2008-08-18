-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, weight, count) VALUES (40, 17.07, 41);
INSERT INTO layout_items (rank, weight, count) VALUES (92, 68.42, 46);
INSERT INTO layout_items (rank, weight, count) VALUES (80, 6.41, 41);
