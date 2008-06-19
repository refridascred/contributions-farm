-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_token ON layout_items (token);

INSERT INTO layout_items (token, region, ratio, score) VALUES ('stable', 'blue', 16.28, 9.97);
INSERT INTO layout_items (token, region, ratio, score) VALUES ('latest', 'primary', 48.93, 32.73);
