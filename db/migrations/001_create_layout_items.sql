-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (owner, rank, token) VALUES ('edge', 89, 'legacy');
INSERT INTO layout_items (owner, rank, token) VALUES ('open', 56, 'staging');
INSERT INTO layout_items (owner, rank, token) VALUES ('green', 94, 'green');
