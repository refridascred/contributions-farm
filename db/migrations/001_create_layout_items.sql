-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, rank) VALUES (23.3, 97);
INSERT INTO layout_items (ratio, rank) VALUES (4.18, 46);
