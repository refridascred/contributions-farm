-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, level, active) VALUES ('stable', 58, 82);
INSERT INTO layout_items (token, level, active) VALUES ('stable', 23, 39);
INSERT INTO layout_items (token, level, active) VALUES ('open', 82, 62);
