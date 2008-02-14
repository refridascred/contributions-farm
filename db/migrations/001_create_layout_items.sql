-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    created_at TIMESTAMP,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, rank, label, region) VALUES ('stable', 28, 'legacy', 'fallback');
INSERT INTO layout_items (token, rank, label, region) VALUES ('latest', 7, 'fallback', 'staging');
INSERT INTO layout_items (token, rank, label, region) VALUES ('fallback', 42, 'latest', 'primary');
