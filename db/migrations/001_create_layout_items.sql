-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (rank, count, owner, token) VALUES (73, 53, 'primary', 'stable');
INSERT INTO layout_items (rank, count, owner, token) VALUES (55, 85, 'latest', 'stable');
INSERT INTO layout_items (rank, count, owner, token) VALUES (67, 46, 'primary', 'stable');
