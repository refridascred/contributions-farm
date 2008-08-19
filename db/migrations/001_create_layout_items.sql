-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (count, rank, ratio) VALUES (85, 42, 46.57);
INSERT INTO layout_items (count, rank, ratio) VALUES (19, 51, 30.92);
INSERT INTO layout_items (count, rank, ratio) VALUES (16, 37, 97.42);
