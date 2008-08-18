-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (owner, count, token, level, weight) VALUES ('local', 96, 'staging', 21, 35.54);
INSERT INTO layout_items (owner, count, token, level, weight) VALUES ('latest', 74, 'staging', 85, 39.81);
INSERT INTO layout_items (owner, count, token, level, weight) VALUES ('open', 99, 'fallback', 23, 67.03);
