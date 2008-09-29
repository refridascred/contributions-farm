-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, rank, count) VALUES (10.55, 73, 20);
INSERT INTO layout_items (weight, rank, count) VALUES (50.19, 70, 8);
