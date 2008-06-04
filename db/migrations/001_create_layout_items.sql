-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, ratio) VALUES (93, 84.77);
INSERT INTO layout_items (rank, ratio) VALUES (95, 89.39);
INSERT INTO layout_items (rank, ratio) VALUES (84, 34.27);
