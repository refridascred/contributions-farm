-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (weight, owner, token, rank) VALUES (92.28, 'latest', 'green', 47);
INSERT INTO layout_items (weight, owner, token, rank) VALUES (64.96, 'stable', 'strict', 31);
