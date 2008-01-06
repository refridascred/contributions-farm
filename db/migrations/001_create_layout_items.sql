-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (rank, ratio) VALUES (50, 62.98);
INSERT INTO layout_items (rank, ratio) VALUES (53, 62.12);
INSERT INTO layout_items (rank, ratio) VALUES (57, 57.73);
