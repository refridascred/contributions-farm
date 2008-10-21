-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, owner, weight) VALUES ('edge', 'eu-west', 49.27);
INSERT INTO layout_items (token, owner, weight) VALUES ('legacy', 'fallback', 19.71);
