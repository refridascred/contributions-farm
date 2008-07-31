-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, count) VALUES ('open', 75);
INSERT INTO layout_items (owner, count) VALUES ('stable', 0);
INSERT INTO layout_items (owner, count) VALUES ('primary', 28);
