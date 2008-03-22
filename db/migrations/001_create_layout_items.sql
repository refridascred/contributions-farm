-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (region, owner, rank) VALUES ('fallback', 'local', 42);
INSERT INTO layout_items (region, owner, rank) VALUES ('green', 'stable', 2);
