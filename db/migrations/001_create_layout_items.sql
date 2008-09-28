-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, owner, label) VALUES ('eu-west', 'eu-west', 'eu-west');
INSERT INTO layout_items (region, owner, label) VALUES ('standard', 'open', 'primary');
INSERT INTO layout_items (region, owner, label) VALUES ('staging', 'open', 'primary');
