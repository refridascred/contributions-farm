-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    owner TEXT NOT NULL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_owner ON layout_items (owner);

INSERT INTO layout_items (ratio, label, owner, level) VALUES (78.14, 'standard', 'standard', 80);
INSERT INTO layout_items (ratio, label, owner, level) VALUES (26.85, 'eu-west', 'standard', 13);
