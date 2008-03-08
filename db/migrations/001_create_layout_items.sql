-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (count, rank, score, owner) VALUES (26, 45, 77.37, 'blue');
INSERT INTO layout_items (count, rank, score, owner) VALUES (60, 50, 12.39, 'blue');
INSERT INTO layout_items (count, rank, score, owner) VALUES (18, 73, 43.13, 'cached');
