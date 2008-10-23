-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (region, rank, token) VALUES ('blue', 17, 'open');
INSERT INTO layout_items (region, rank, token) VALUES ('cached', 61, 'stable');
