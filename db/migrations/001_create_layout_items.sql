-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (level, token, owner, label, ratio) VALUES (82, 'primary', 'standard', 'blue', 40.93);
INSERT INTO layout_items (level, token, owner, label, ratio) VALUES (24, 'standard', 'primary', 'local', 30.93);
INSERT INTO layout_items (level, token, owner, label, ratio) VALUES (50, 'edge', 'eu-west', 'blue', 64.47);
