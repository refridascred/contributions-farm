-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_rank ON layout_items (rank);

INSERT INTO layout_items (token, rank, owner, count, label) VALUES ('cached', 22, 'cached', 62, 'legacy');
INSERT INTO layout_items (token, rank, owner, count, label) VALUES ('local', 13, 'legacy', 96, 'strict');
INSERT INTO layout_items (token, rank, owner, count, label) VALUES ('open', 24, 'cached', 98, 'open');
