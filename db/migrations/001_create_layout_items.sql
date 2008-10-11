-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (region, token, level, active, count) VALUES ('edge', 'eu-west', 7, 6, 85);
INSERT INTO layout_items (region, token, level, active, count) VALUES ('latest', 'primary', 17, 4, 46);
INSERT INTO layout_items (region, token, level, active, count) VALUES ('open', 'eu-west', 43, 7, 14);
