-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, score) VALUES ('edge', 79.17);
INSERT INTO layout_items (owner, score) VALUES ('green', 66.35);
INSERT INTO layout_items (owner, score) VALUES ('open', 86.22);
