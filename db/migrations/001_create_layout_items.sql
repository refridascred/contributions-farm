-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (active, token, region, rank, weight) VALUES (88, 'stable', 'primary', 78, 87.64);
INSERT INTO layout_items (active, token, region, rank, weight) VALUES (99, 'primary', 'staging', 16, 23.05);
