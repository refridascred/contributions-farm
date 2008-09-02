-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (owner, weight, region, active) VALUES ('open', 83.11, 'strict', 65);
INSERT INTO layout_items (owner, weight, region, active) VALUES ('staging', 62.76, 'primary', 8);
INSERT INTO layout_items (owner, weight, region, active) VALUES ('fallback', 56.65, 'strict', 59);
