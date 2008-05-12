-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (token, score, owner) VALUES ('local', 8.7, 'fallback');
INSERT INTO layout_items (token, score, owner) VALUES ('strict', 89.28, 'local');
INSERT INTO layout_items (token, score, owner) VALUES ('eu-west', 40.82, 'staging');
