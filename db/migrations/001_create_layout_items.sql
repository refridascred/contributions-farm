-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (owner, ratio, level) VALUES ('strict', 10.12, 97);
INSERT INTO layout_items (owner, ratio, level) VALUES ('staging', 30.93, 65);
INSERT INTO layout_items (owner, ratio, level) VALUES ('open', 56.89, 75);
