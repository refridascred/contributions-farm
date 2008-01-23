-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, owner, label, level) VALUES ('eu-west', 'edge', 'stable', 81);
INSERT INTO layout_items (region, owner, label, level) VALUES ('local', 'cached', 'legacy', 46);
