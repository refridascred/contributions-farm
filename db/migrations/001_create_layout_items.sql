-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    rank INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (token, rank, ratio, label) VALUES ('cached', 33, 91.33, 'strict');
INSERT INTO layout_items (token, rank, ratio, label) VALUES ('local', 5, 6.77, 'open');
INSERT INTO layout_items (token, rank, ratio, label) VALUES ('blue', 48, 79.49, 'staging');
