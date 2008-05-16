-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, owner, count) VALUES (85, 'edge', 42);
INSERT INTO layout_items (rank, owner, count) VALUES (72, 'staging', 63);
INSERT INTO layout_items (rank, owner, count) VALUES (54, 'standard', 10);
