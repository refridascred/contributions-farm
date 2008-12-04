-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (rank, owner, count) VALUES (63, 'fallback', 93);
INSERT INTO layout_items (rank, owner, count) VALUES (94, 'legacy', 36);
INSERT INTO layout_items (rank, owner, count) VALUES (81, 'legacy', 67);
