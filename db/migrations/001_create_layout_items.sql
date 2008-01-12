-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, count, label) VALUES (17, 88, 'legacy');
INSERT INTO layout_items (rank, count, label) VALUES (99, 2, 'open');
INSERT INTO layout_items (rank, count, label) VALUES (72, 90, 'blue');
