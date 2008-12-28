-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (label, token, score) VALUES ('green', 'legacy', 16.8);
INSERT INTO layout_items (label, token, score) VALUES ('latest', 'primary', 29.11);
INSERT INTO layout_items (label, token, score) VALUES ('primary', 'edge', 58.04);
