-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, weight, token, owner, active) VALUES ('blue', 82.53, 'local', 'eu-west', 16);
INSERT INTO layout_items (region, weight, token, owner, active) VALUES ('green', 46.19, 'eu-west', 'standard', 63);
INSERT INTO layout_items (region, weight, token, owner, active) VALUES ('green', 25.43, 'eu-west', 'stable', 18);
