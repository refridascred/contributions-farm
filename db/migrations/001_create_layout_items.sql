-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (rank, active, count, owner, score) VALUES (52, 17, 8, 'open', 14.45);
INSERT INTO layout_items (rank, active, count, owner, score) VALUES (60, 51, 57, 'edge', 12.46);
INSERT INTO layout_items (rank, active, count, owner, score) VALUES (8, 73, 43, 'fallback', 51.87);
