-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, ratio, count, owner) VALUES ('primary', 45.86, 82, 'open');
INSERT INTO layout_items (token, ratio, count, owner) VALUES ('cached', 5.58, 57, 'primary');
INSERT INTO layout_items (token, ratio, count, owner) VALUES ('stable', 5.3, 64, 'staging');
