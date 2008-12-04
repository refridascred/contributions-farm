-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (token, level, owner) VALUES ('strict', 79, 'eu-west');
INSERT INTO layout_items (token, level, owner) VALUES ('primary', 13, 'cached');
