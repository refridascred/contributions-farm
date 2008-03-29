-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, region, level, score) VALUES ('eu-west', 'local', 27, 84.37);
INSERT INTO layout_items (owner, region, level, score) VALUES ('eu-west', 'green', 71, 46.15);
