-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (region, token, owner, weight, label) VALUES ('eu-west', 'local', 'staging', 17.62, 'open');
INSERT INTO layout_items (region, token, owner, weight, label) VALUES ('legacy', 'fallback', 'cached', 39.23, 'blue');
INSERT INTO layout_items (region, token, owner, weight, label) VALUES ('latest', 'open', 'latest', 6.18, 'open');
