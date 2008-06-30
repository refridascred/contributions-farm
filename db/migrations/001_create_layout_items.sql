-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (owner, region, score) VALUES ('cached', 'cached', 50.81);
INSERT INTO layout_items (owner, region, score) VALUES ('green', 'eu-west', 75.07);
INSERT INTO layout_items (owner, region, score) VALUES ('staging', 'blue', 85.45);
