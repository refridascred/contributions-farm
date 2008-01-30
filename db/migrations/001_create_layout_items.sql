-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (count, rank, owner, label) VALUES (85, 92, 'latest', 'edge');
INSERT INTO layout_items (count, rank, owner, label) VALUES (64, 64, 'fallback', 'open');
INSERT INTO layout_items (count, rank, owner, label) VALUES (13, 99, 'local', 'blue');
