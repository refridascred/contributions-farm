-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (label, count, owner, ratio) VALUES ('staging', 20, 'blue', 44.45);
INSERT INTO layout_items (label, count, owner, ratio) VALUES ('staging', 59, 'legacy', 76.56);
INSERT INTO layout_items (label, count, owner, ratio) VALUES ('standard', 6, 'edge', 17.95);
