-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    token TEXT,
    region TEXT,
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (token, region, label, owner) VALUES ('staging', 'fallback', 'strict', 'edge');
INSERT INTO layout_items (token, region, label, owner) VALUES ('standard', 'stable', 'open', 'open');
INSERT INTO layout_items (token, region, label, owner) VALUES ('latest', 'stable', 'eu-west', 'green');
