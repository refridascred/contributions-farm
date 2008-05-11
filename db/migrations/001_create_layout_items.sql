-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (token, count, level, ratio) VALUES ('open', 63, 69, 43.73);
INSERT INTO layout_items (token, count, level, ratio) VALUES ('latest', 52, 10, 83.71);
INSERT INTO layout_items (token, count, level, ratio) VALUES ('local', 0, 93, 48.0);
