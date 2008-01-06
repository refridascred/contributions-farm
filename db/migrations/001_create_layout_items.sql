-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, rank, token, ratio) VALUES (2, 14, 'primary', 71.65);
INSERT INTO layout_items (count, rank, token, ratio) VALUES (8, 69, 'open', 92.45);
