-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    label TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, ratio, label, rank) VALUES ('stable', 85.76, 'cached', 56);
INSERT INTO layout_items (token, ratio, label, rank) VALUES ('cached', 76.16, 'stable', 11);
INSERT INTO layout_items (token, ratio, label, rank) VALUES ('cached', 17.01, 'staging', 62);
