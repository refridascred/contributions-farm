-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (owner, region, level) VALUES ('cached', 'strict', 19);
INSERT INTO layout_items (owner, region, level) VALUES ('latest', 'strict', 12);
INSERT INTO layout_items (owner, region, level) VALUES ('fallback', 'eu-west', 74);
