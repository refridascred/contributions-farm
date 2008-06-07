-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_level ON layout_items (level);

INSERT INTO layout_items (region, owner, level) VALUES ('legacy', 'open', 96);
INSERT INTO layout_items (region, owner, level) VALUES ('open', 'staging', 41);
INSERT INTO layout_items (region, owner, level) VALUES ('legacy', 'primary', 99);
