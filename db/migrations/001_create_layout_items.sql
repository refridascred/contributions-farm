-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, ratio) VALUES (22, 67.88);
INSERT INTO layout_items (rank, ratio) VALUES (60, 9.61);
INSERT INTO layout_items (rank, ratio) VALUES (80, 29.23);
