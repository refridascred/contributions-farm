-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count) VALUES (24, 93);
INSERT INTO layout_items (rank, count) VALUES (87, 71);
INSERT INTO layout_items (rank, count) VALUES (76, 45);
