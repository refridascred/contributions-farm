-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, rank, label, owner, score) VALUES (64, 31, 'green', 'blue', 20.05);
INSERT INTO layout_items (active, rank, label, owner, score) VALUES (12, 63, 'local', 'latest', 90.44);
INSERT INTO layout_items (active, rank, label, owner, score) VALUES (99, 37, 'legacy', 'green', 38.43);
