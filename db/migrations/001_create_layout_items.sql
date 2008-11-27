-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, token, rank, score) VALUES ('eu-west', 'legacy', 18, 88.98);
INSERT INTO layout_items (owner, token, rank, score) VALUES ('blue', 'local', 72, 32.22);
