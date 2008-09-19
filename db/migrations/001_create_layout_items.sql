-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, token, count, label) VALUES (10, 'blue', 72, 'legacy');
INSERT INTO layout_items (rank, token, count, label) VALUES (13, 'legacy', 99, 'eu-west');
