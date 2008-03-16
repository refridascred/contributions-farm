-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, count, rank, level, owner) VALUES ('green', 70, 15, 24, 'stable');
INSERT INTO layout_items (token, count, rank, level, owner) VALUES ('legacy', 87, 44, 75, 'green');
INSERT INTO layout_items (token, count, rank, level, owner) VALUES ('staging', 39, 92, 87, 'legacy');
