-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, rank, owner, token) VALUES (47.51, 55, 'cached', 'strict');
INSERT INTO layout_items (ratio, rank, owner, token) VALUES (29.66, 8, 'latest', 'legacy');
INSERT INTO layout_items (ratio, rank, owner, token) VALUES (21.17, 86, 'standard', 'primary');
