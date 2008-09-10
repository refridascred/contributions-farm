-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (active, owner, count, score) VALUES (97, 'eu-west', 85, 14.51);
INSERT INTO layout_items (active, owner, count, score) VALUES (78, 'latest', 64, 88.26);
